
const mapCharts = new Map();

function activateChart(chartId, config) {
    let chart = undefined;
    if (mapCharts.has(chartId)) {
        chart = mapCharts.get(chartId);
        chart.data = config.data;
        chart.options = config.options;
        chart.update();
    }
    else {
        const chartContext = document.getElementById(chartId);
        chart = new Chart(chartContext, config);
        mapCharts.set(chartId, chart);
    }
}

function disposeChart(chartId) {
    if (mapCharts.has(chartId)) {
        const chart = mapCharts.get(chartId);
        mapCharts.delete(chartId);
        chart.destroy();
    }
}

export {
    activateChart,
    disposeChart
}

