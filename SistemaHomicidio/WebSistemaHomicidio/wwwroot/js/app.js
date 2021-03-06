//Máscaras para os campos
window.masks = () => {

    var boeMask = IMask(
        document.getElementById('boe-mask'), {
        mask: '00E0000000000'
    });

    var latMask = IMask(
        document.getElementById('lat-mask'), {
        mask: '0.00000'
    });

    var longMask = IMask(
        document.getElementById('long-mask'), {
        mask: '00.00000'
    });
};

//Dowloads de Arquivos
async function downloadFileFromStream(fileName, contentStreamReference) {
    const arrayBuffer = await contentStreamReference.arrayBuffer();
    const blob = new Blob([arrayBuffer]);

    const url = URL.createObjectURL(blob);

    triggerFileDownload(fileName, url);

    URL.revokeObjectURL(url);
}

function triggerFileDownload(fileName, url) {
    const anchorElement = document.createElement('a');
    anchorElement.href = url;

    if (fileName) {
        anchorElement.download = fileName;
    }

    anchorElement.click();
    anchorElement.remove();
}