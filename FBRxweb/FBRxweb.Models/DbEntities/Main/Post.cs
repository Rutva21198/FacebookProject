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
    [Table("Posts",Schema="dbo")]
    public partial class Post
    {
		#region PostId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region Media Annotations

        [Required]
		#endregion Media Annotations

        public string Media { get; set; }

		#region CreatedDateTime Annotations

        [Required]
		#endregion CreatedDateTime Annotations

        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region MediaTypeAO Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FBApplicationObjects","dbo","","MediaTypeAO")]
		#endregion MediaTypeAO Annotations

        public int MediaTypeAO { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.Posts))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region FBApplicationObject Annotations

        [ForeignKey(nameof(MediaTypeAO))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FBApplicationObject.Posts))]
		#endregion FBApplicationObject Annotations

        public virtual FBApplicationObject FBApplicationObject { get; set; }

		#region PostCaptions Annotations

        [InverseProperty("Post")]
		#endregion PostCaptions Annotations

        public virtual ICollection<PostCaption> PostCaptions { get; set; }

		#region PostComments Annotations

        [InverseProperty("Post")]
		#endregion PostComments Annotations

        public virtual ICollection<PostComment> PostComments { get; set; }

		#region PostLikes Annotations

        [InverseProperty("Post")]
		#endregion PostLikes Annotations

        public virtual ICollection<PostLike> PostLikes { get; set; }

		#region PostShares Annotations

        [InverseProperty("Post")]
		#endregion PostShares Annotations

        public virtual ICollection<PostShare> PostShares { get; set; }


        public Post()
        {
			PostCaptions = new HashSet<PostCaption>();
			PostComments = new HashSet<PostComment>();
			PostLikes = new HashSet<PostLike>();
			PostShares = new HashSet<PostShare>();
        }
	}
}