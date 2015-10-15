COMSCORE.SiteRecruit.Broker.config = {	version: "5.0.3",	cddsDomains: 'store.microsoft.com|xbox.com|www.microsoft.com|go.microsoft.com|windowsphone.com|microsoftstore.com|(templates|support).office.com',	cddsInProgress: 'cddsinprogress',	domainSwitch: 'tracking3p',	domainMatch: '([\\da-z\.-]+\.com)',	delay: 3000,		testMode: false,	cookie:{		name: 'msresearch',		path: '/',		domain:  '.microsoft.com' ,		duration: 90,		rapidDuration: 0,		expireDate: ''	},	thirdPartyOptOutCookieEnabled : false,	prefixUrl: "",	Events: {beforeRecruit: function() { var _halt = true; 
var _days = false;var _stC = readCookie("ST_GN_EN-US"); if(_stC){  var _s = _stC.split('.');  _t = _s[0].split('_');	_d = _t[1];  var mult = 86400000; if(_d && _d > 0){ var myDate = new Date().getTime(); var b = myDate - (_d * mult); _days = (b/mult); }} 
if(typeof ms != 'undefined' && typeof ms.ssversion != 'undefined'){ if(ms.ssversion == '200'){ _halt = false; }} if(typeof document.getElementsByName('ms.ssversion')[0] != 'undefined' && typeof document.getElementsByName('ms.ssversion')[0].getAttribute('content') != 'undefined'){	_ssvervion = document.getElementsByName('ms.ssversion')[0].getAttribute('content'); if(_ssvervion == '200'){ _halt = false;}} if(_days && _days <= 90 && /en-us/i.test(window.location.toString())){ _halt = true;} COMSCORE.SiteRecruit._halt = _halt;
var screenWidth = self.screen.availWidth, screenHeight = self.screen.availHeight; if(/iphone|ipad|ipod|android|opera mini|blackberry|bb10|mobile safari|windows (phone|ce)|iemobile|htc|nokia|mobile/i.test(navigator.userAgent) || screenWidth <= 450 ){ COMSCORE.SiteRecruit._halt = true;} 
if(/test=comscore/i.test(window.location.toString()) || /tstMode=1/i.test(document.cookie)){ COMSCORE.SiteRecruit._halt = false;} }},mapping:[ 
{m: '/en-us', c: 'inv_c_p329970507-en-us.js', f: 0.035, p: 0 },
{m: '/en-gb', c: 'inv_c_p329970507-en-gb.js', f: 0.1297, p: 0 },
{m: '/es-es', c: 'inv_c_p329970507-es-es.js', f: 0.0734, p: 0 },
{m: '/pt-br', c: 'inv_c_p329970507-pt-br.js', f: 0.0581, p: 0 },
{m: '/zh-cn', c: 'inv_c_p329970507_ZH-CN.js', f: 0.0948, p: 0 },
{m: '/ja-jp', c: 'inv_c_p329970507_JA-JP.js', f: 0.1326, p: 0 },
{m: '/fr-fr', c: 'inv_c_p329970507_FR-FR.js', f: 0.1163, p: 0 },
{m: '/de-de', c: 'inv_c_p329970507_DE-DE.js', f: 0.1273, p: 0 },
{m: '/ru-ru', c: 'inv_c_p329970507_RU-RU.js', f: 0.0585, p: 0 },
//{m: '/en-id', c: 'inv_c_p329970507_EN-ID.js', f: 100, p: 0 ,prereqs:{	content: [] ,cookie: [ {'name':'tstMode','value':'1'}] ,externalDomain: [] } },
{m: '/it-it', c: 'inv_c_p329970507_IT-IT.js', f: 0.1222, p: 0 },
{m: '/nl-nl', c: 'inv_c_p329970507_NL-NL.js', f: 0.2419, p: 0 },
{m: '/ko-kr', c: 'inv_c_p329970507_KO-KR.js', f: 0.3276, p: 0 },
{m: '/zh-tw', c: 'inv_c_p329970507_ZH-TW.js', f: 0.5, p: 0 },
{m: '/es-mx', c: 'inv_c_p329970507_ES-MX.js', f: 0.4563, p: 0 },
{m: '/pl-pl', c: 'inv_c_p329970507_PL-PL.js', f: 0.5, p: 0 },
{m: '/en-au', c: 'inv_c_p329970507_EN-AU.js', f: 0.5, p: 0 },
{m: '/tr-tr', c: 'inv_c_p329970507_TR-TR.js', f: 0.3806, p: 0 },
{m: '/cs-cz', c: 'inv_c_p329970507-cs-cz.js', f: 0.3194, p: 0 },
{m: '/en-ca', c: 'inv_c_p329970507-en-ca.js', f: 0.4637, p: 0 },
{m: '/en-nz', c: 'inv_c_p329970507-en-nz.js', f: 0.5, p: 0 },
{m: '/fr-ch', c: 'inv_c_p329970507-fr-ch.js', f: 0.5, p: 0 },
{m: '/hu-hu', c: 'inv_c_p329970507-hu-hu.js', f: 0.5, p: 0 },
{m: '/pt-pt', c: 'inv_c_p329970507-pt-pt.js', f: 0.2157, p: 0 },
{m: '/sv-se', c: 'inv_c_p329970507-sv-se.js', f: 0.3869, p: 0 },
{m: '/th-th', c: 'inv_c_p329970507-th-th.js', f: 0.5, p: 0 },
{m: '/vi-vn', c: 'inv_c_p329970507-vi-vn.js', f: 0.5, p: 0 },

{m: '/en-in', c: 'inv_c_p329970507-en-in.js', f: 0.4184, p: 0 },
{m: '/en-za', c: 'inv_c_p329970507-en-za.js', f: 0.5, p: 0 },
{m: '/fr-ca', c: 'inv_c_p329970507-fr-ca.js', f: 0.3403, p: 0 },
{m: '/de-ch', c: 'inv_c_p329970507-de-ch.js', f: 0.5, p: 0 },
{m: '/nl-be', c: 'inv_c_p329970507-nl-be.js', f: 0.4921, p: 0 },
{m: '/es-ar', c: 'inv_c_p329970507-es-ar.js', f: 0.2857, p: 0 },
{m: '/es-co', c: 'inv_c_p329970507-es-co.js', f: 0.5, p: 0 },
{m: '/fr-be', c: 'inv_c_p329970507-fr-be.js', f: 0.5, p: 0 },

{m: 'test=comscore', c: 'inv_c_p329970507.js', f: 0.05, p: 1 ,prereqs:{	content: [] ,cookie: [ {'name':'tstMode','value':'1'}] ,externalDomain: [] } }
]}; function readCookie(name){var ca = document.cookie.split(';');  var nameEQ = name + "=";  for(var i=0; i < ca.length; i++) { var c = ca[i];  while (c.charAt(0)==' ') c = c.substring(1, c.length); if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length); }  return false;}var gIdelay = 0;if (readCookie("graceIncr") == 1) {	gIdelay = 5000;} setTimeout(function(){_set_SessionCookie("graceIncr", 0)},gIdelay);function _set_SessionCookie(_name, _val) {  if (_name == COMSCORE.SiteRecruit.Broker.config.domainSwitch) {		var r = new RegExp(COMSCORE.SiteRecruit.Broker.config.domainMatch,'i');		if (r.test(_val)) { _val = RegExp.$1 + RegExp.$2; var c = _name + '=' + _val + '; path=/' + '; domain=' + COMSCORE.SiteRecruit.Broker.config.cookie.domain; document.cookie = c; }	}else if(COMSCORE.isDDInProgress()){ 	if(_name == "captlinks"){	if(/^http(s)?\:/i.test(_val)){var _reg = new RegExp("http(s)?://"+document.domain+"/", "i");	var _val = _val.replace(_reg, '');}	if(_val && _val.length > 2){c_vals = readCookie("captlinks");if(c_vals){	if(c_vals.indexOf(_val) == -1){	var str = c_vals +"," + _val;	if(str.length <= 1240){	_val = str;	}else{ _val=false; }}else{ _val = false; }}}}	if(_val){  		var c = _name+'=' + _val + '; path=/' + '; domain=' + COMSCORE.SiteRecruit.Broker.config.cookie.domain; document.cookie = c; }}}
setTimeout('_set_SessionCookie("graceIncr","0")', 3000);function SRappendEventListener(srElement, _name, _val){	if(srElement.addEventListener){	srElement.addEventListener('click',function(event){	_set_SessionCookie(_name, _val); },false);}else{ srElement.attachEvent('onclick',function(){	_set_SessionCookie(_name, _val); });}}
function checkLink(){ var allLinks = document.getElementsByTagName("a");for (var i = 0, n = allLinks.length; i < n; i++){	var r = new RegExp(COMSCORE.SiteRecruit.Broker.config.cddsDomains,'i');	var _clickURL = allLinks[i].href;	if (r.test(_clickURL)) {		if (/store.microsoft.com/i.test(_clickURL)) { _clickURL = ".microsoftstore.com" }	if (/microsoft.com\/windowsphone/i.test(_clickURL)) { _clickURL = ".windowsphone.com" }	if (!(/microsoft.com/i.test(_clickURL))) { SRappendEventListener(allLinks[i], COMSCORE.SiteRecruit.Broker.config.domainSwitch, _clickURL);		}	}try{	if(_clickURL && _clickURL != '' && !(/javascript\:void(0)/i.test(_clickURL)) ){		if(/login\.live|msacademicverify|(o15\.officeredir|office)\.microsoft\.com|login|LiveLogin|(office|office\.microsoft|live|skype|onedrive)\.com/i.test(_clickURL)){ SRappendEventListener(allLinks[i], "graceIncr", 1);} if(/(contactus\/(technicalsupport|setupandinstallation)) || (my\/(account|devicesoftware|supportrequests) ) /i.test(_clickURL)){ if(/sign in/i.test(document.getElementById("idPPScarab").innerHTML)) { SRappendEventListener(allLinks[i], "graceIncr", 1);	}}}} catch(e){}}var cs_inputs = document.getElementsByTagName('input');for(var c=0; c<cs_inputs.length; c++){  if(cs_inputs[c].getAttribute('ms.cmpnm')=='signin'){  	SRappendEventListener(cs_inputs[c], "graceIncr", 1);	}} }  setTimeout("checkLink();", 2000);
function checkDivs(){ var cs_divs = document.getElementsByTagName('div'); for(var c=0; c<cs_divs.length; c++){ if(/msame_Header_name msame_TxtTrunc|msame_Header msame_unauth/i.test(cs_divs[c].getAttribute('class'))){ 
SRappendEventListener(cs_divs[c], "graceIncr", 1); }}} setTimeout("checkDivs();", 4000);
function crossDomainCheck() {	if (intervalMax > 0) { intervalMax --;	var cookieName = COMSCORE.SiteRecruit.Broker.config.cddsInProgress;	if (COMSCORE.SiteRecruit.Utils.UserPersistence.getCookieValue(cookieName) != false ) {	COMSCORE.SiteRecruit.DDKeepAlive.setDDTrackerCookie();	COMSCORE.SiteRecruit._halt = true; clearCrossDomainCheck();	}} else {	clearCrossDomainCheck(); }}
function clearCrossDomainCheck(){window.clearInterval(crossDomainInterval);} var intervalMax = 10;var crossDomainInterval = window.setInterval('crossDomainCheck()', '1000'); if (COMSCORE.SiteRecruit.Broker.delayConfig == true) {	COMSCORE.SiteRecruit.Broker.config.delay = 1000;} if(( !(/support.microsoft.com/i.test(document.referrer)) || document.referrer == '' ) && COMSCORE.SiteRecruit.Broker.isDDInProgress() == false) {	COMSCORE.SiteRecruit.Broker.config.delay = 8000; }
window.setTimeout('COMSCORE.SiteRecruit.Broker.run()', COMSCORE.SiteRecruit.Broker.config.delay);