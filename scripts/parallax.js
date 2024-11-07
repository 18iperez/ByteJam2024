document.addEventListener('mousemove', (e) => {
    const layers = document.querySelectorAll('.layer');
    const x = (window.innerWidth / 2 - e.pageX) / 100;
    const y = (window.innerHeight / 2 - e.pageY) / 100;

    layers.forEach((layer, index) => {
        const speed = (index + 1) * 10; // Adjust speed factor for each layer
        layer.style.transform = `translate(${x * speed}px, ${y * speed}px)`;
    });
});
