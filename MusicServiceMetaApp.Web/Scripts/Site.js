$(document).ready(function () {
    var canvasEl = document.createElement('canvas');

    drawAlbumCover(canvasEl);

    var canvasImgUrl = canvasEl.toDataURL();

    var placeholders = $('.missingAlbumCoverCanvasPlaceholder');
    $.each(placeholders, function (key, divEl) {
        $(divEl).append('<img src="' + canvasImgUrl + '" alt="">');
    });
});

function drawAlbumCover(canvas) {
    var context = canvas.getContext('2d');
    context.strokeRect(0, 0, 150, 150);
    context.fillStyle = '#f0f0f0';
    context.fillRect(1, 1, 148, 148);
}
