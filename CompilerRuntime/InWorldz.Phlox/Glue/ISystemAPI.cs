
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMetaverse;

using InWorldz.Phlox.Types;

namespace InWorldz.Phlox.Glue
{
	public interface ISystemAPI
	{
        void SetScriptEventFlags();
        void ShoutError(string errorText);
        void OnScriptReset();
        void OnStateChange();
        void OnScriptUnloaded(ScriptUnloadReason reason, VM.RuntimeState.LocalDisableFlag localFlag);
        void AddExecutionTime(double ms);
        void OnScriptInjected(bool fromCrossing);
        void OnGroupCrossedAvatarReady(UUID avatarId);
        float GetAverageScriptTime();

		float llSin(float theta);
		float llCos(float theta);
		float llTan(float theta);
		float llAtan2(float y,float x);
		float llSqrt(float val);
		float llPow(float decbase,float exponent);
		int llAbs(int val);
		float llFabs(float val);
		float llFrand(float mag);
		int llFloor(float val);
		int llCeil(float val);
		int llRound(float val);
		float llVecMag(Vector3 v);
		Vector3 llVecNorm(Vector3 v);
		float llVecDist(Vector3 v1,Vector3 v2);
		Vector3 llRot2Euler(Quaternion q);
		Quaternion llEuler2Rot(Vector3 v);
		Quaternion llAxes2Rot(Vector3 fwd,Vector3 left,Vector3 up);
		Vector3 llRot2Fwd(Quaternion q);
		Vector3 llRot2Left(Quaternion q);
		Vector3 llRot2Up(Quaternion q);
		Quaternion llRotBetween(Vector3 v1,Vector3 v2);
		void llWhisper(int channel,string msg);
		void llSay(int channel,string msg);
		void llShout(int channel,string msg);
		int llListen(int channel,string name,string id,string msg);
		void llListenControl(int number,int active);
		void llListenRemove(int number);
		void llSensor(string name,string id,int type,float range,float arc);
		void llSensorRepeat(string name,string id,int type,float range,float arc,float rate);
		void llSensorRemove();
		string llDetectedName(int number);
		string llDetectedKey(int number);
		string llDetectedOwner(int number);
		int llDetectedType(int number);
		Vector3 llDetectedPos(int number);
		Vector3 llDetectedVel(int number);
		Vector3 llDetectedGrab(int number);
		Quaternion llDetectedRot(int number);
		int llDetectedGroup(int number);
		int llDetectedLinkNumber(int number);
		void llDie();
		float llGround(Vector3 offset);
		float llCloud(Vector3 offset);
		Vector3 llWind(Vector3 offset);
		void llSetStatus(int status,int value);
		int llGetStatus(int status);
		void llSetScale(Vector3 scale);
		Vector3 llGetScale();
		void llSetColor(Vector3 color,int face);
		float llGetAlpha(int face);
		void llSetAlpha(float alpha,int face);
		Vector3 llGetColor(int face);
		void llSetTexture(string texture,int face);
		void llScaleTexture(float u,float v,int face);
		void llOffsetTexture(float u,float v,int face);
		void llRotateTexture(float rot,int face);
		string llGetTexture(int face);
		void llSetPos(Vector3 pos);
		Vector3 llGetPos();
		Vector3 llGetLocalPos();
		void llSetRot(Quaternion rot);
		Quaternion llGetRot();
		Quaternion llGetLocalRot();
		void llSetForce(Vector3 force,int local);
		Vector3 llGetForce();
		int llTarget(Vector3 position,float range);
		void llTargetRemove(int number);
		int llRotTarget(Quaternion rot,float error);
		void llRotTargetRemove(int number);
		void llMoveToTarget(Vector3 target,float tau);
		void llStopMoveToTarget();
		void llApplyImpulse(Vector3 force,int local);
		void llApplyRotationalImpulse(Vector3 force,int local);
		void llSetTorque(Vector3 torque,int local);
		Vector3 llGetTorque();
		void llSetForceAndTorque(Vector3 force,Vector3 torque,int local);
		Vector3 llGetVel();
        Vector3 iwGetAngularVelocity();
		Vector3 llGetAccel();
		Vector3 llGetOmega();
		float llGetTimeOfDay();
		float llGetWallclock();
		float llGetTime();
		void llResetTime();
		float llGetAndResetTime();
		void llSound(string sound,float volume,int queue,int loop);
		void llPlaySound(string sound,float volume);
		void llLoopSound(string sound,float volume);
		void llLoopSoundMaster(string sound,float volume);
		void llLoopSoundSlave(string sound,float volume);
		void llPlaySoundSlave(string sound,float volume);
		void llTriggerSound(string sound,float volume);
		void llStopSound();
		void llPreloadSound(string sound);
		string llGetSubString(string src,int start,int end);
		string llDeleteSubString(string src,int start,int end);
		string llInsertString(string dst,int position,string src);
		string llToUpper(string src);
		string llToLower(string src);
		int llGiveMoney(string destination,int amount);
		void llMakeExplosion(int particles,float scale,float vel,float lifetime,float arc,string texture,Vector3 offset);
		void llMakeFountain(int particles,float scale,float vel,float lifetime,float arc,int bounce,string texture,Vector3 offset,float bounce_offset);
		void llMakeSmoke(int particles,float scale,float vel,float lifetime,float arc,string texture,Vector3 offset);
		void llMakeFire(int particles,float scale,float vel,float lifetime,float arc,string texture,Vector3 offset);
		void llRezObject(string inventory,Vector3 pos,Vector3 vel,Quaternion rot,int param);
		void llLookAt(Vector3 target,float strength,float damping);
		void llStopLookAt();
		void llSetTimerEvent(float sec);
		void llSleep(float sec);
		float llGetMass();
		void llCollisionFilter(string name,string id,int accept);
		void llTakeControls(int controls,int accept,int pass_on);
		void llReleaseControls();
		void llAttachToAvatar(int attach_point);
		void llDetachFromAvatar();
		void llTakeCamera(string avatar);
		void llReleaseCamera(string avatar);
		string llGetOwner();
		void llInstantMessage(string user,string message);
		void llEmail(string address,string subject,string message);
		void llGetNextEmail(string address,string subject);
		string llGetKey();
		void llSetBuoyancy(float buoyancy);
		void llSetHoverHeight(float height,int water,float tau);
		void llStopHover();
		void llMinEventDelay(float delay);
		void llSoundPreload(string sound);
		void llRotLookAt(Quaternion target,float strength,float damping);
		int llStringLength(string str);
		void llStartAnimation(string anim);
		void llStopAnimation(string anim);
		void llPointAt(Vector3 pos);
		void llStopPointAt();
		void llTargetOmega(Vector3 axis,float spinrate,float gain);
		int llGetStartParameter();
		void llGodLikeRezObject(string inventory,Vector3 pos);
		void llRequestPermissions(string agent,int perm);
		string llGetPermissionsKey();
		int llGetPermissions();
		int llGetLinkNumber();
		void llSetLinkColor(int linknumber,Vector3 color,int face);
		void llCreateLink(string target,int parent);
		void llBreakLink(int linknum);
		void llBreakAllLinks();
		string llGetLinkKey(int linknumber);
		string llGetLinkName(int linknumber);
		int llGetInventoryNumber(int type);
		string llGetInventoryName(int type,int number);
		void llSetScriptState(string name,int run);
		float llGetEnergy();
		void llGiveInventory(string destination,string inventory);
		void llRemoveInventory(string item);
		void llSetText(string text,Vector3 color,float alpha);
		float llWater(Vector3 offset);
		void llPassTouches(int pass);
		void llRequestAgentData(string id,int data);
        string llRequestInventoryData(string name);
		void llSetDamage(float damage);
		void llTeleportAgentHome(string id);
		void llModifyLand(int action,int brush);
		void llCollisionSound(string impact_sound,float impact_volume);
		void llCollisionSprite(string impact_sprite);
		string llGetAnimation(string id);
		void llResetScript();
		void llMessageLinked(int linknum,int num,string str,string id);
		void llPushObject(string id,Vector3 impulse,Vector3 ang_impulse,int local);
		void llPassCollisions(int pass);
		string llGetScriptName();
		int llGetNumberOfSides();
		Quaternion llAxisAngle2Rot(Vector3 axis,float angle);
		Vector3 llRot2Axis(Quaternion rot);
		float llRot2Angle(Quaternion rot);
		float llAcos(float val);
		float llAsin(float val);
		float llAngleBetween(Quaternion a,Quaternion b);
		string llGetInventoryKey(string name);
		void llAllowInventoryDrop(int add);
		Vector3 llGetSunDirection();
		Vector3 llGetTextureOffset(int face);
		Vector3 llGetTextureScale(int side);
		float llGetTextureRot(int side);
		int llSubStringIndex(string source,string pattern);
        string llGetOwnerKey(string id);
		Vector3 llGetCenterOfMass();
		LSLList llListSort(LSLList src,int stride,int ascending);
		int llGetListLength(LSLList src);
		int llList2Integer(LSLList src,int index);
		float llList2Float(LSLList src,int index);
		string llList2String(LSLList src,int index);
		string llList2Key(LSLList src,int index);
		Vector3 llList2Vector(LSLList src,int index);
		Quaternion llList2Rot(LSLList src,int index);
		LSLList llList2List(LSLList src,int start,int end);
		LSLList llDeleteSubList(LSLList src,int start,int end);
		int llGetListEntryType(LSLList src,int index);
		string llList2CSV(LSLList src);
		LSLList llCSV2List(string src);
		LSLList llListRandomize(LSLList src,int stride);
		LSLList llList2ListStrided(LSLList src,int start,int end,int stride);
		Vector3 llGetRegionCorner();
		LSLList llListInsertList(LSLList dest,LSLList src,int start);
		int llListFindList(LSLList src,LSLList test);
		string llGetObjectName();
		void llSetObjectName(string name);
		string llGetDate();
		int llEdgeOfWorld(Vector3 pos,Vector3 dir);
		int llGetAgentInfo(string id);
		void llAdjustSoundVolume(float volume);
		void llSetSoundQueueing(int queue);
		void llSetSoundRadius(float radius);
		string llKey2Name(string id);
		void llSetTextureAnim(int mode,int face,int sizex,int sizey,float start,float length,float rate);
		void llTriggerSoundLimited(string sound,float volume,Vector3 top_north_east,Vector3 bottom_south_west);
		void llEjectFromLand(string avatar);
        LSLList iwParseString2List(string src, LSLList separators, LSLList spacers, LSLList args);
		LSLList llParseString2List(string src,LSLList separators,LSLList spacers);
		int llOverMyLand(string id);
		string llGetLandOwnerAt(Vector3 pos);
		string llGetNotecardLine(string name,int line);
		Vector3 llGetAgentSize(string id);
		int llSameGroup(string id);
		void llUnSit(string id);
		Vector3 llGroundSlope(Vector3 offset);
		Vector3 llGroundNormal(Vector3 offset);
		Vector3 llGroundContour(Vector3 offset);
		int llGetAttached();
		int llGetFreeMemory();
        int llGetUsedMemory();
        string llGetRegionName();
		float llGetRegionTimeDilation();
		float llGetRegionFPS();
		void llParticleSystem(LSLList rules);
		void llGroundRepel(float height,int water,float tau);
		void llGiveInventoryList(string target,string folder,LSLList inventory);
		void llSetVehicleType(int type);
		void llSetVehicleFloatParam(int param,float value);
		void llSetVehicleVectorParam(int param,Vector3 vec);
        void llSetVehicleRotationParam(int param, Quaternion rot);
		void llSetVehicleFlags(int flags);
		void llRemoveVehicleFlags(int flags);
		void llSitTarget(Vector3 offset,Quaternion rot);
		string llAvatarOnSitTarget();
		void llAddToLandPassList(string avatar,float hours);
		void llSetTouchText(string text);
		void llSetSitText(string text);
		void llSetCameraEyeOffset(Vector3 offset);
		void llSetCameraAtOffset(Vector3 offset);
		string llDumpList2String(LSLList src,string separator);
		int llScriptDanger(Vector3 pos);
		void llDialog(string avatar,string message,LSLList buttons,int chat_channel);
		void llVolumeDetect(int detect);
		void llResetOtherScript(string name);
		int llGetScriptState(string name);
		void llSetRemoteScriptAccessPin(int pin);
		void llRemoteLoadScriptPin(string target,string name,int pin,int running,int start_param);
		void llOpenRemoteDataChannel();
		string llSendRemoteData(string channel,string dest,int idata,string sdata);
		void llRemoteDataReply(string channel,string message_id,string sdata,int idata);
		void llCloseRemoteDataChannel(string channel);
		string llMD5String(string src,int nonce);
		void llSetPrimitiveParams(LSLList rules);
		string llStringToBase64(string str);
		string llBase64ToString(string str);
		string llXorBase64Strings(string s1,string s2);
		float llLog10(float val);
		float llLog(float val);
		LSLList llGetAnimationList(string id);
		void llSetParcelMusicURL(string url);
        string llGetParcelMusicURL();
        Vector3 llGetRootPosition();
		Quaternion llGetRootRotation();
		string llGetObjectDesc();
		void llSetObjectDesc(string name);
		string llGetCreator();
		string llGetTimestamp();
		void llSetLinkAlpha(int linknumber,float alpha,int face);
		int llGetNumberOfPrims();
		string llGetNumberOfNotecardLines(string name);
		LSLList llGetBoundingBox(string obj);
		Vector3 llGetGeometricCenter();
		LSLList llGetPrimitiveParams(LSLList parms);
		string llIntegerToBase64(int number);
		int llBase64ToInteger(string str);
		float llGetGMTclock();
		string llGetSimulatorHostname();
		void llSetLocalRot(Quaternion rot);
		LSLList llParseStringKeepNulls(string src,LSLList separators,LSLList spacers);
		void llRezAtRoot(string inventory,Vector3 pos,Vector3 vel,Quaternion rot,int param);
		int llGetObjectPermMask(int mask);
		void llSetObjectPermMask(int mask,int value);
		int llGetInventoryPermMask(string item,int mask);
		void llSetInventoryPermMask(string item,int mask,int value);
		string llGetInventoryCreator(string item);
		void llOwnerSay(string msg);
		string llRequestSimulatorData(string simulator,int data);
		void llForceMouselook(int mouselook);
		float llGetObjectMass(string id);
		LSLList llListReplaceList(LSLList dest,LSLList src,int start,int end);
		void llLoadURL(string avatar,string message,string url);
		void llParcelMediaCommandList(LSLList command);
		LSLList llParcelMediaQuery(LSLList query);
		int llModPow(int a,int b,int c);
		int llGetInventoryType(string name);
		void llSetPayPrice(int price,LSLList quick_pay_buttons);
		Vector3 llGetCameraPos();
		Quaternion llGetCameraRot();
		void llSetPrimURL(string url);
		void llRefreshPrimURL();
		string llEscapeURL(string url);
		string llUnescapeURL(string url);
		void llMapDestination(string simname,Vector3 pos,Vector3 look_at);
		void llAddToLandBanList(string avatar,float hours);
		void llRemoveFromLandPassList(string avatar);
		void llRemoveFromLandBanList(string avatar);
		void llSetCameraParams(LSLList rules);
		void llClearCameraParams();
		float llListStatistics(int operation,LSLList src);
		int llGetUnixTime();
		int llGetParcelFlags(Vector3 pos);
		int llGetRegionFlags();
		string llXorBase64StringsCorrect(string s1,string s2);
		string llHTTPRequest(string url,LSLList parameters,string body);
		void llResetLandBanList();
		void llResetLandPassList();
		int llGetObjectPrimCount(string object_id);
		LSLList llGetParcelPrimOwners(Vector3 pos);
		int llGetParcelPrimCount(Vector3 pos,int category,int sim_wide);
		int llGetParcelMaxPrims(Vector3 pos,int sim_wide);
		LSLList llGetParcelDetails(Vector3 pos,LSLList parms);
		void llSetLinkPrimitiveParams(int linknumber,LSLList rules);
		void llSetLinkTexture(int linknumber,string texture,int face);
		string llStringTrim(string src,int trim_type);
		void llRegionSay(int channel,string msg);
		LSLList llGetObjectDetails(string id,LSLList parms);

		void llSetClickAction(int action);
		int llGetRegionAgentCount();
		void llTextBox(string avatar,string message,int chat_channel);
		string llGetAgentLanguage(string avatar);
		Vector3 llDetectedTouchUV(int index);
		int llDetectedTouchFace(int index);
		Vector3 llDetectedTouchPos(int index);
		Vector3 llDetectedTouchNormal(int index);
		Vector3 llDetectedTouchBinormal(int index);
		Vector3 llDetectedTouchST(int index);
		string llSHA1String(string src);
		int llGetFreeURLs();
		string llRequestURL();
		string llRequestSecureURL();
		void llReleaseURL(string url);
		void llHTTPResponse(string request_id,int status,string body);
		string llGetHTTPHeader(string request_id,string header);
		int llSetPrimMediaParams(int face,LSLList parms);
        int llSetLinkMedia(int link, int face, LSLList parms);
		LSLList llGetPrimMediaParams(int face,LSLList parms);
        LSLList llGetLinkMedia(int link, int face, LSLList parms);
		int llClearPrimMedia(int face);
        int llClearLinkMedia(int link, int face);
		void llSetLinkPrimitiveParamsFast(int linknumber,LSLList rules);
		LSLList llGetLinkPrimitiveParams(int linknumber,LSLList rules);
		void llLinkParticleSystem(int linknumber,LSLList rules);
		void llSetLinkTextureAnim(int link,int mode,int face,int sizex,int sizey,float start,float length,float rate);
		int llGetLinkNumberOfSides(int link);
		string llGetUsername(string id);
		void llRequestUsername(string id);
		string llGetDisplayName(string id);
		void llRequestDisplayName(string id);
		void iwMakeNotecard(string name,LSLList data);
		void iwAvatarName2Key(string firstName,string lastName);
        void iwLinkTargetOmega(int linknumber, Vector3 axis, float spinrate, float gain);
        int llSetRegionPos(Vector3 position);
        int iwGetLinkInventoryNumber(int linknumber, int type);
        int iwGetLinkInventoryType(int linknumber, string name);
        int iwGetLinkInventoryPermMask(int linknumber, string item, int mask);
        string iwGetLinkInventoryName(int linknumber, int type, int number);
        string iwGetLinkInventoryKey(int linknumber, string name);
        string iwGetLinkInventoryCreator(int linknumber, string item);
        string iwSHA256String(string src);
        void iwTeleportAgent(string agent, string region, Vector3 pos, Vector3 lookat);
        string llAvatarOnLinkSitTarget(int linknumber);
        string iwGetLastOwner();
        void iwRemoveLinkInventory(int linknumber, string item);
        void iwGiveLinkInventory(int linknumber, string destination, string inventory);
        void iwGiveLinkInventoryList(int linknumber, string target, string folder, LSLList inventory);
        string iwGetNotecardSegment(string name, int line, int startOffset, int maxLength);
        string iwGetLinkNumberOfNotecardLines(int linknumber, string name);
        string iwGetLinkNotecardLine(int linknumber, string name, int line);
        string iwGetLinkNotecardSegment(int linknumber, string name, int line, int startOffset, int maxLength);
        int iwActiveGroup(string agent, string group);
        string iwAvatarOnLink(int linknumber);
        void llRegionSayTo(string destId, int channel, string msg);
        string iwGetLinkInventoryDesc(int linknumber, string name);
        string llGenerateKey();
        string iwGetLinkInventoryLastOwner(int linknumber, string name);
        string llGetEnv(string name);
        void llSetAngularVelocity(Vector3 force, int local);
        LSLList llGetPhysicsMaterial();
        void llSetPhysicsMaterial(int mask, float gravityMultiplier, float restitution, float friction, float density);
        void llSetVelocity(Vector3 force, int local);
        void iwRezObject(string inventory, Vector3 pos, Vector3 vel, Quaternion rot, int param);
        void iwRezAtRoot(string inventory, Vector3 pos, Vector3 vel, Quaternion rot, int param);
        string iwRezPrim(LSLList primParams, LSLList particleSystem, LSLList inventory, Vector3 pos, Vector3 vel, Quaternion rot, int param);
        LSLList llGetAgentList(int scope, LSLList options);
        LSLList iwGetAgentList(int scope, Vector3 minPos, Vector3 maxPos, LSLList paramList);
        LSLList iwGetWorldBoundingBox(string obj);
        int llSetMemoryLimit(int limit);
        int llGetMemoryLimit();
        void llManageEstateAccess(int action, string avatar);
        int iwSubStringIndex(string source, string pattern, int offset, int isCaseSensitive);
        void llLinkSitTarget(int link, Vector3 offset, Quaternion rot);
		float llGetMassMKS();
        float iwGetObjectMassMKS(string id);
        void llSetLinkCamera(int link, Vector3 eyeOffset, Vector3 cameraAt);
        void iwSetGround(int x1, int y1, int x2, int y2, float height);
        void llSetContentType(string request_id, int content_type);
        string llJsonGetValue(string json, LSLList specifiers);
        string llJsonValueType(string json, LSLList specifiers);
        string llJsonSetValue(string json, LSLList specifiers, string value);
        string llList2Json(string type, LSLList values);
        LSLList llJson2List(string src);
        void iwSetWind(int type, Vector3 offset, Vector3 speed);
        Vector3 iwWind(Vector3 offset);
        int iwHasParcelPowers(int groupPower);
        Vector3 iwGroundSurfaceNormal(Vector3 offset);
        string iwRequestAnimationData(string name);
        LSLList llCastRay(Vector3 start, Vector3 end, LSLList options);
        void llSetKeyframedMotion(LSLList keyframes, LSLList options);
        int iwGetLocalTime();
        int iwGetLocalTimeOffset();
        string iwFormatTime(int unixtime, int isUTC, string format);
        int iwCheckRezError(Vector3 pos, int isTemp, int landImpact);

        void botCreateBot(string FirstName, string LastName, string outfitName, Vector3 startPos, int options);//Returns string via async return
        void botAddTag(string botID, string tag);
        void botRemoveTag(string botID, string tag);
        LSLList botGetBotsWithTag(string tag);
        void botRemoveBotsWithTag(string tag);
        void botRemoveBot(string botID);
        void botPauseMovement(string botID);
        void botResumeMovement(string botID); 
        void botWhisper(string botID, int channel, string message);
        void botSay(string botID, int channel, string message);
        void botShout(string botID, int channel, string message);
        void botStartTyping(string botID);
        void botStopTyping(string botID);
        void botSendInstantMessage(string botID, string userID, string message);
        void botSitObject(string botID, string objectID);
        void botStandUp(string botID);
        string botGetOwner(string botID);
        int botIsBot(string userID);
        void botTouchObject(string bot, string objectID);
        void botSetMovementSpeed(string botID, float speed);
        Vector3 botGetPos(string botID);
        string botGetName(string botID);
        void botStartAnimation(string botID, string animation);
        void botStopAnimation(string botID, string animation);
        void botTeleportTo(string botID, Vector3 position);
        void botChangeOwner(string botID, string newOwnerID);
        LSLList botGetAllBotsInRegion();
        LSLList botGetAllMyBotsInRegion();
        int botFollowAvatar(string botID, string avatar, LSLList options);
        void botStopMovement(string botID);
        void botSetNavigationPoints(string botID, LSLList positions, LSLList movementTypes, LSLList options);
        void botRegisterForNavigationEvents(string botID);
        void botSetProfile(string botID, string aboutText, string email, string firstLifeAboutText,
            string firstLifeImageUUID, string imageUUID, string profileURL);
        void botSetRotation(string botID, Quaternion rotation);
        void botGiveInventory(string botID, string destination, string inventory);
        void botSensor(string botID, string name, string id, int type, float range, float arc);
        void botSensorRepeat(string botID, string name, string id, int type, float range, float arc, float rate);
        void botSensorRemove();
        string iwDetectedBot();
        int botListen(string botID, int channel, string name, string id, string msg);
        void botRegisterForCollisionEvents(string botID);
        void botDeregisterFromCollisionEvents(string botID);
        void botDeregisterFromNavigationEvents(string botID);
        void botSetOutfit(string outfitName);
        void botRemoveOutfit(string outfitName);
        void botChangeOutfit(string botID, string outfitName);
        void botGetBotOutfits();//Returns LSLList via async return
        void botWanderWithin(string botID, Vector3 origin, float xDistance, float yDistance, LSLList options);
        void botMessageLinked(string botID, int num, string msg, string id);
        void botSetProfileParams(string botID, LSLList profileInformation);
        LSLList botGetProfileParams(string botID, LSLList profileInformation);
        int iwGetAppearanceParam(string who, int which);
        int iwChar2Int(string src, int index);
        string iwInt2Char(int num);
        string iwReplaceString(string str, string pattern, string replacement);
        string iwFormatString(string str, LSLList values);
        int iwMatchString(string str, string pattern, int matchType);
        string iwStringCodec(string str, string pattern, int operation, LSLList extraParams);
        int iwMatchList(LSLList list1, LSLList list2, int matchType);
        Vector3 iwColorConvert(Vector3 input, int color1, int color2);
        Vector3 iwNameToColor(string name);
        int iwVerifyType(string str, int type);
        int iwGroupInvite(string group, string user, string role);
        int iwGroupEject(string group, string user);
        string iwGetAgentData(string id, int data);
        int iwIsPlusUser(string id);
        void llAttachToAvatarTemp(int attachPoint);
    }
}
