using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.Models.Enums.Main;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("FBApplicationObjects",Schema="dbo")]
    public partial class FBApplicationObject
    {
		#region ApplicationObjectId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ApplicationObjectId Annotations

        public int ApplicationObjectId { get; set; }

		#region ApplicationObjectTypeId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FBApplicationObjectTypes","dbo","","ApplicationObjectTypeId")]
		#endregion ApplicationObjectTypeId Annotations

        public int ApplicationObjectTypeId { get; set; }

		#region ApplicationObjectName Annotations

        [Required]
        [MaxLength(50)]
		#endregion ApplicationObjectName Annotations

        public string ApplicationObjectName { get; set; }

		#region FBApplicationObjectType Annotations

        [ForeignKey(nameof(ApplicationObjectTypeId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FBApplicationObjectType.FBApplicationObjects))]
		#endregion FBApplicationObjectType Annotations

        public virtual FBApplicationObjectType FBApplicationObjectType { get; set; }

		#region FacebookUserDetails Annotations

        [InverseProperty("FBApplicationObject")]
		#endregion FacebookUserDetails Annotations

        public virtual ICollection<FacebookUserDetail> FacebookUserDetails { get; set; }

		#region FacebookUsers Annotations

        [InverseProperty("FBApplicationObject")]
		#endregion FacebookUsers Annotations

        public virtual ICollection<FacebookUser> FacebookUsers { get; set; }

		#region Posts Annotations

        [InverseProperty("FBApplicationObject")]
		#endregion Posts Annotations

        public virtual ICollection<Post> Posts { get; set; }

		#region ChatMedia Annotations

        [InverseProperty("FBApplicationObject")]
		#endregion ChatMedia Annotations

        public virtual ICollection<ChatMedia> ChatMedia { get; set; }

		#region EducationDetails Annotations

        [InverseProperty("FBApplicationObject")]
		#endregion EducationDetails Annotations

        public virtual ICollection<EducationDetail> EducationDetails { get; set; }


        public FBApplicationObject()
        {
			FacebookUserDetails = new HashSet<FacebookUserDetail>();
			FacebookUsers = new HashSet<FacebookUser>();
			Posts = new HashSet<Post>();
			ChatMedia = new HashSet<ChatMedia>();
			EducationDetails = new HashSet<EducationDetail>();
        }
	}
}