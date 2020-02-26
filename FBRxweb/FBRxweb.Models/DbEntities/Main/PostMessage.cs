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
    [Table("PostMessages",Schema="dbo")]
    public partial class PostMessage
    {
		#region PostMessageId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostMessageId Annotations

        public int PostMessageId { get; set; }

		#region Message Annotations

        [Required]
		#endregion Message Annotations

        public string Message { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region PostDateTime Annotations

        [Required]
		#endregion PostDateTime Annotations

        public System.DateTimeOffset PostDateTime { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.PostMessages))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region PostMessageLikes Annotations

        [InverseProperty("PostMessage")]
		#endregion PostMessageLikes Annotations

        public virtual ICollection<PostMessageLike> PostMessageLikes { get; set; }

		#region PostMessageComments Annotations

        [InverseProperty("PostMessage")]
		#endregion PostMessageComments Annotations

        public virtual ICollection<PostMessageComment> PostMessageComments { get; set; }

		#region PostMessageShares Annotations

        [InverseProperty("PostMessage")]
		#endregion PostMessageShares Annotations

        public virtual ICollection<PostMessageShare> PostMessageShares { get; set; }


        public PostMessage()
        {
			PostMessageLikes = new HashSet<PostMessageLike>();
			PostMessageComments = new HashSet<PostMessageComment>();
			PostMessageShares = new HashSet<PostMessageShare>();
        }
	}
}