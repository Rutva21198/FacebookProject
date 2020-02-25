import {PostBase} from '../database-models/post-base';
import {FacebookUserBase} from '../database-models/facebook-user-base';
import {FBApplicationObjectBase} from '../database-models/f-b-application-object-base';
import {PostCaptionBase} from '../database-models/post-caption-base';
import {PostCommentBase} from '../database-models/post-comment-base';
import {PostLikeBase} from '../database-models/post-like-base';
import {PostShareBase} from '../database-models/post-share-base';
//Generated Imports
export class Post extends PostBase 
{




//#region Generated Reference Properties
//#region facebookUser Prop
facebookUser : FacebookUserBase;
//#endregion facebookUser Prop
//#region fBApplicationObject Prop
fBApplicationObject : FBApplicationObjectBase;
//#endregion fBApplicationObject Prop
//#region postCaptions Prop
postCaptions : PostCaptionBase[];
//#endregion postCaptions Prop
//#region postComments Prop
postComments : PostCommentBase[];
//#endregion postComments Prop
//#region postLikes Prop
postLikes : PostLikeBase[];
//#endregion postLikes Prop
//#region postShares Prop
postShares : PostShareBase[];
//#endregion postShares Prop

//#endregion Generated Reference Properties





}