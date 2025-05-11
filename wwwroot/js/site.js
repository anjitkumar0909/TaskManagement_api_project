// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const targetNode = document.getElementById('someElement');
targetNode.addEventListener('DOMNodeInserted', function (event) {
    console.log('A new node was inserted:', event.target);
    // Your logic here
});

//const targetNode = document.getElementById('someElement');
//const observer = new MutationObserver(function (mutationsList) {
//    for (let mutation of mutationsList) {
//        if (mutation.type === 'childList' && mutation.addedNodes.length > 0) {
//            mutation.addedNodes.forEach(function (node) {
//                console.log('A new node was inserted:', node);
//                // Your logic here
//            });
//        }
//    }
//});

//const config = { childList: true, subtree: true }; // Observe direct children and descendants
//observer.observe(targetNode, config);

//// To stop observing later:
//// observer.disconnect();