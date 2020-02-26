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
    [Table("PostMessageLikes",Schema="dbo")]
    public partial class PostMessageLike
    {
		#region PostMessageLikeId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostMessageLikeId Annotations

        public int PostMessageLikeId { get; set; }

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
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.PostMessageLikes))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region PostMessage Annotations

        [ForeignKey(nameof(PostMessageId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.PostMessage.PostMessageLikes))]
		#endregion PostMessage Annotations

        public virtual PostMessage PostMessage { get; set; }


        public PostMessageLike()
        {
        }
	}
}