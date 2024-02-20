
function activateChart(chartId, config) {
    let conf = JSON.parse(config);
    
    const chartContext = document.getElementById(chartId);
    const chart = new Chart(chartContext, conf);
}

export {
    activateChart
}

