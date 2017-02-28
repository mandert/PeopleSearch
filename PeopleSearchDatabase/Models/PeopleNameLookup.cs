using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleSearchDatabase.Models
{
    public class PeopleNameLookup
    {
        /// <summary>
        /// PeopleSearch Database PeopleNameLookup Object. This object was specifically created to
        /// improve the performance of searching for parts of a person's first and last name.
        /// </summary>
        public int PeopleNameLookupId { get; set; }

        [Index("NamePartIndex"), MaxLength(40)]
        public string NamePart { get; set; }
        public bool NameStart { get; set; }

        public virtual Person Person { get; set; }
    }
}
