
function activateChart(chartId, config) {
    const chartContext = document.getElementById(chartId);
    const chart = new Chart(chartContext, config);
}

export {
    activateChart
}

