angular.module('homeIndex', [])
.controller('search', function ($scope, $http) {
    // Initialize Field Values
    $scope.addedMsDelay = '0';
    $scope.lastRequestedPage = 1;
    $scope.itemsPerPage = 10;
    $scope.totalNumberOfPages = 0;
    $scope.pageLinks = [];
    $scope.errorOccurred = false;

    // Function to centralize the generation of a "PageNav" object.
    function getPageNavInstance() {
        var pageNav = (function () {
            // Private variables
            var pageIdx;
            var pageIdxSet = false;

            // Public functions
            return {
                setPageIndex: function (x) {
                    pageIdx = x;
                    pageIdxSet = true;
                },

                searchForPeople: function () {
                    $scope.searchForPeople(pageIdx);
                },

                isEnabled: function () {
                    return pageIdxSet;
                }
            }
        })();

        return pageNav;
    }

    // Function to set the page navigation links.
    $scope.setPageLinks = function() {
        $scope.pageLinks = [];

        // Hard coded value of 4 indicates the user will only see up to 4 pages below
        // and up to 4 pages above the currently selected page.
        var pageLinkPlusMinus = 4;
        $scope.totalNumberOfPages = Math.ceil($scope.searchForPeopleResponse.ResultsFound / $scope.itemsPerPage);
        
        // Only build page links if there is more than 1 page
        if ($scope.totalNumberOfPages > 1) {
            // ****************************
            // * Build Previous Page Link *
            // ****************************
            if ($scope.lastRequestedPage !== 1) {
                var prevNavFunction = getPageNavInstance();
                prevNavFunction.setPageIndex($scope.lastRequestedPage - 1);
                $scope.pageLinks.push({ text: "Prev", navFunction: prevNavFunction });
            }

            // ***************************
            // * Build Middle Page Links *
            // ***************************

            // Determine the lowest page to build.
            var lowestDisplayedPageLink = $scope.lastRequestedPage - pageLinkPlusMinus;
            if (lowestDisplayedPageLink < 1) {
                lowestDisplayedPageLink = 1;
            }

            // Determine the highest page to build.
            var highestDisplayedPageLink = $scope.lastRequestedPage + pageLinkPlusMinus;
            if (highestDisplayedPageLink > $scope.totalNumberOfPages) {
                highestDisplayedPageLink = $scope.totalNumberOfPages;
            }

            // Actually build the middle page links.
            for (var i = lowestDisplayedPageLink; i <= highestDisplayedPageLink; i++) {
                var pageNavFunction = null;
                if ($scope.lastRequestedPage !== i) {
                    pageNavFunction = getPageNavInstance();
                    pageNavFunction.setPageIndex(i);
                }
                $scope.pageLinks.push({ text: "Page " + i, navFunction: pageNavFunction });
            }

            // ************************
            // * Build Next Page Link *
            // ************************
            if ($scope.lastRequestedPage < $scope.totalNumberOfPages) {
                var nextNavFunction = getPageNavInstance();
                nextNavFunction.setPageIndex($scope.lastRequestedPage + 1);
                $scope.pageLinks.push({ text: "Next", navFunction: nextNavFunction });
            }
            
        }  
    };

    // Function to execute the search for people.
    $scope.searchForPeople = function (requestedPage) {
        // Only display the overlay if the request takes longer than 0.25 seconds
        var stillProcessing = true;
        setTimeout(function () {
            if (stillProcessing) {
                $scope.toggleOverlay(true);
            }
        }, 250);

        // Keep track of the last page requested.
        $scope.lastRequestedPage = requestedPage;

        // Only make the ajax POST call if there is value to the searchKeyword
        if ($scope.searchKeyword) {
            // Set the request object properties.
            var searchForPeopleRequest = {
                'Keyword': $scope.searchKeyword,
                'RequestedPage': $scope.lastRequestedPage,
                'ItemsPerPage': $scope.itemsPerPage,
                'SearchDelayMs': $scope.addedMsDelay
            };

            // Set the request header type to Json
            var config = {
                headers: {
                    'Content-Type': 'application/json; charset=utf-8'
                }
            }

            // Make the Ajax POST request
            $http.post('/Home/SearchForPeople/', searchForPeopleRequest, config)
                .then(function successCallback(response) {
                    // Ajax call Success
                    stillProcessing = false;
                    $scope.errorOccurred = false;
                    $scope.searchForPeopleResponse = response.data;
                    $scope.setPageLinks();
                    $scope.toggleOverlay(false);
                    $("html, body").animate({ scrollTop: 0 }, "slow");
                }, function errorCallback(response) {
                    // Ajax call Error
                    stillProcessing = false;
                    $scope.errorOccurred = true;

                    // Reset Fields
                    $scope.searchForPeopleResponse = null;
                    $scope.lastRequestedPage = 1;
                    $scope.totalNumberOfPages = 0;

                    // Turn off overlay
                    $scope.toggleOverlay(false);

                    // Scroll to the top of the screen
                    $("html, body").animate({ scrollTop: 0 }, "slow");
                });
        }
        else {
            // If the searchKeyword doesn't have value clear the searchForPeopleResponse;
            stillProcessing = false;
            $scope.searchForPeopleResponse = null;
        }
    };

    // Function to enable/disable the overlay. Overlay is used to (1) indicate the user processing is underway
    // and (2) prevent the user from making any further changes to the page.
    $scope.toggleOverlay = function (enable) {
        var loadingOverlayContainer = $('#overlay');

        if (enable) {
            if (loadingOverlayContainer.length === 0) {
                // Logic to ensure focus on any element is removed.
                $("#txtSearchKeyword").focus().blur();

                // Create and append the overlay to the body.
                var over = '<div id="overlay">' + '<img id="loading" src="/Images/Loading.gif">' + '</div>';
                $(over).appendTo('body');
            }
        } else {
            if (loadingOverlayContainer.length > 0) {
                // Overlay exists. Remove it.
                loadingOverlayContainer.remove();
            }
        }
    };
});