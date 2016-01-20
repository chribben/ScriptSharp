var edge = require('electron-edge')

var hello = edge.func(function () {/*
   async (input) => { 
       return ".NET welcomes " + input.ToString(); 
   }
*/});

hello('Node.js', function (error, result) {
   if (error) throw error;
   console.log(result);
});

 var ta = document.getElementById('ta');
ta.onkeydown = function (event) {
    if (event.defaultPrevented) {
        return;
    }
    var handled = false;
    if (event.key !== undefined) {
        if (event.key === 'Enter' && event.altKey) {
            sendCode(getSelectedText());
        }
    } else if (event.keyIdentifier !== undefined) {
        if (event.keyIdentifier === "Enter" && event.altKey) {
            sendCode(getSelectedText());
        }

    } else if (event.keyCode !== undefined) {
        if (event.keyCode === 13 && event.altKey) {
            sendCode(getSelectedText());
        }
    }
    if (handled) {
        event.preventDefault();
    };
 };

function sendCode(code)
{
 //   var xmlhttp = new XMLHttpRequest();
 //   xmlhttp.open("POST", "http://localhost:9000/api/code", true);
 //   xmlhttp.setRequestHeader("Content-type","application/json");
 //   xmlhttp.send("'" + code + "'");
 //   alert('Code sent: ' + code);
    alert('Selected code: ' + code);
}
function getSelectedText() {
    var ta = document.getElementById('ta');
    var selectedText;
    // IE version
    if (document.selection != undefined) {
        ta.focus();
        var sel = document.selection.createRange();
        selectedText = sel.text;
    }
    // Mozilla version
    else if (ta.selectionStart != undefined) {
        var startPos = ta.selectionStart;
        var endPos = ta.selectionEnd;
        selectedText = ta.value.substring(startPos, endPos)
    }
    return selectedText;

}
