window.JSLib = {
    getInnerHtml: function (element) {
        //console.log("JSElement: " + element);
        if (element === null)
            return "";
        else
            return element.innerHTML.replace(/<!--!-->/g, "");
    },
    getInnerHtmlById: function (id) {
        return window.JSLib.getInnerHtml(document.getElementById(id));
    },
    getOuterHtml: function (element) {
        //console.log("JSElement: " + element);
        if (element === null)
            return "";
        else
            return element.outerHTML.replace(/<!--!-->/g, "");
    },
    getOuterHtmlById: function (id) {
        return window.JSLib.getOuterHtml(document.getElementById(id));
    }
};