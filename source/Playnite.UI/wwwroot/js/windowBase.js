let dragData = null;
let resizeData = null;

export function initializeDrag(element) {
    const rect = element.getBoundingClientRect();
    dragData = {
        element,
        startX: event.clientX - rect.left,
        startY: event.clientY - rect.top
    };

    document.addEventListener('mousemove', handleDragMove);
    document.addEventListener('mouseup', handleDragEnd);
}

export function initializeResize(element) {
    const rect = element.getBoundingClientRect();
    resizeData = {
        element,
        startWidth: rect.width,
        startHeight: rect.height,
        startX: event.clientX,
        startY: event.clientY
    };

    document.addEventListener('mousemove', handleResizeMove);
    document.addEventListener('mouseup', handleResizeEnd);
}

function handleDragMove(e) {
    if (!dragData) return;

    const x = e.clientX - dragData.startX;
    const y = e.clientY - dragData.startY;

    dragData.element.style.left = `${x}px`;
    dragData.element.style.top = `${y}px`;
}

function handleDragEnd() {
    dragData = null;
    document.removeEventListener('mousemove', handleDragMove);
    document.removeEventListener('mouseup', handleDragEnd);
}

function handleResizeMove(e) {
    if (!resizeData) return;

    const width = resizeData.startWidth + (e.clientX - resizeData.startX);
    const height = resizeData.startHeight + (e.clientY - resizeData.startY);

    resizeData.element.style.width = `${Math.max(200, width)}px`;
    resizeData.element.style.height = `${Math.max(100, height)}px`;
}

function handleResizeEnd() {
    resizeData = null;
    document.removeEventListener('mousemove', handleResizeMove);
    document.removeEventListener('mouseup', handleResizeEnd);
}

export function minimizeWindow(element) {
    element.style.display = 'none';
}

export function maximizeWindow(element) {
    element.style.top = '0';
    element.style.left = '0';
    element.style.width = '100vw';
    element.style.height = '100vh';
    element.style.transform = 'none';
}

export function restoreWindow(element) {
    element.style.width = '600px';
    element.style.height = '400px';
    element.style.top = '50%';
    element.style.left = '50%';
    element.style.transform = 'translate(-50%, -50%)';
}
