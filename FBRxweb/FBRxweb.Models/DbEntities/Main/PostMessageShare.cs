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
    [Table("PostMessageShares",Schema="dbo")]
    public partial class PostMessageShare
    {
		#region PostMessageShareId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostMessageShareId Annotations

        public int PostMessageShareId { get; set; }

		#region PostMessageId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("PostMessages","dbo","","PostMessageId")]
		#endregion PostMessageId Annotations

        public int PostMessageId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.PostMessageShares))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region PostMessage Annotations

        [ForeignKey(nameof(PostMessageId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.PostMessage.PostMessageShares))]
		#endregion PostMessage Annotations

        public virtual PostMessage PostMessage { get; set; }


        public PostMessageShare()
        {
        }
	}
}