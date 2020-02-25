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
    [Table("PostCaptions",Schema="dbo")]
    public partial class PostCaption
    {
		#region PostCaptionId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostCaptionId Annotations

        public int PostCaptionId { get; set; }

		#region Caption Annotations

        [Required]
		#endregion Caption Annotations

        public string Caption { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Posts","dbo","","PostId")]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region Post Annotations

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.Post.PostCaptions))]
		#endregion Post Annotations

        public virtual Post Post { get; set; }


        public PostCaption()
        {
        }
	}
}