import {PostMessageBase} from '../database-models/post-message-base';
import {FacebookUserBase} from '../database-models/facebook-user-base';
import {PostMessageLikeBase} from '../database-models/post-message-like-base';
import {PostMessageCommentBase} from '../database-models/post-message-comment-base';
import {PostMessageShareBase} from '../database-models/post-message-share-base';
//Generated Imports
export class PostMessage extends PostMessageBase 
{




//#region Generated Reference Properties
//#region facebookUser Prop
facebookUser : FacebookUserBase;
//#endregion facebookUser Prop
//#region postMessageLikes Prop
postMessageLikes : PostMessageLikeBase[];
//#endregion postMessageLikes Prop
//#region postMessageComments Prop
postMessageComments : PostMessageCommentBase[];
//#endregion postMessageComments Prop
//#region postMessageShares Prop
postMessageShares : PostMessageShareBase[];
//#endregion postMessageShares Prop

//#endregion Generated Reference Properties









}