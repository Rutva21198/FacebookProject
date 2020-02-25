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
    [Table("PostLikes",Schema="dbo")]
    public partial class PostLike
    {
		#region LikeId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LikeId Annotations

        public int LikeId { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Posts","dbo","","PostId")]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.PostLikes))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region Post Annotations

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.Post.PostLikes))]
		#endregion Post Annotations

        public virtual Post Post { get; set; }


        public PostLike()
        {
        }
	}
}