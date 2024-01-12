
function activateChart(chartId, labels, datasets) {
    const chartContext = document.getElementById(chartId);
    const data = {
        labels,
        datasets
    };
    const config = {
        type: 'bar',
        data: data,
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top',
                },
                title: {
                    display: true,
                    text: 'Chart.js Line Chart'
                }
            }
        },
    };
    const chart = new Chart(chartContext, config);
}

export {
    activateChart
}

