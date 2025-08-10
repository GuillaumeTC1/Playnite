export function fadeIn(instance, state, startOpacity) {
    const duration = 500; // 500ms animation duration
    const startTime = performance.now();
    const start = startOpacity;

    function animate(currentTime) {
        const elapsed = currentTime - startTime;
        const progress = Math.min(elapsed / duration, 1);
        
        // Ease in-out function
        const opacity = start + (1 - start) * (progress < 0.5
            ? 2 * progress * progress
            : 1 - Math.pow(-2 * progress + 2, 2) / 2);
        
        instance.invokeMethodAsync('UpdateOpacity', state, opacity);
        
        if (progress < 1) {
            requestAnimationFrame(animate);
        }
    }
    
    requestAnimationFrame(animate);
}

export function fadeOut(instance, state, startOpacity) {
    const duration = 500; // 500ms animation duration
    const startTime = performance.now();
    const start = startOpacity;

    function animate(currentTime) {
        const elapsed = currentTime - startTime;
        const progress = Math.min(elapsed / duration, 1);
        
        // Ease in-out function
        const opacity = start - start * (progress < 0.5
            ? 2 * progress * progress
            : 1 - Math.pow(-2 * progress + 2, 2) / 2);
        
        instance.invokeMethodAsync('UpdateOpacity', state, opacity);
        
        if (progress < 1) {
            requestAnimationFrame(animate);
        }
    }
    
    requestAnimationFrame(animate);
}
