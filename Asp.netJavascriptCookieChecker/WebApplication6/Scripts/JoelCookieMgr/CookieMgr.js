"use strict"

var CookieMgr = function (cookieName) {
    this.cookieName = cookieName;
};

CookieMgr.prototype.deleteCookie = function () {
    var cookieString = this.cookieName + "=tobedeleted; expires=Fri, 23 Dec 2011 12:00:00 UTC"; // random date in past
    document.cookie = cookieString;
}

CookieMgr.prototype.setCookie = function (cookieValue) {
    var cookieString = this.cookieName + "=" + JSON.stringify(cookieValue)
                     + "; expires=Sun, 18 Dec 2050 12:00:00 UTC"; // random date in future
    document.cookie = cookieString;
}

CookieMgr.prototype.getCookie= function () {
    var key, val, res;
    //get all cookie
    var cookies = document.cookie.split(';');
    for (var i = 0; i < cookies.length; i++) {
        key = cookies[i].substr(0, cookies[i].indexOf("="));
        val = cookies[i].substr(cookies[i].indexOf("=") + 1);
        key = key.replace(/^\s+|\s+$/g, "");
        //find "response_cookie"
        if (key == this.cookieName) {
            return val;
        }
    }
    return null;
}