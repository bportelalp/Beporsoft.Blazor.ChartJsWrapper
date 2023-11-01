
let chart;



const DATA_COUNT = 7;
const NUMBER_CFG = { count: DATA_COUNT, min: -100, max: 100 };

const labels = ["Jan", "Feb", "Mar", "Apr", "May"];
const data = {
    labels: labels,
    datasets: [
        {
            label: 'Dataset 1',
            data: [1,3,2,4,1],
            borderColor: "#FF0000",
            backgroundColor: "#FF0000",
        },
        {
            label: 'Dataset 2',
            data: [1, 5, 7, 0, 4],
            borderColor: "#0000FF",
            backgroundColor: "#0000FF",
        }
    ]
};
const config = {
    type: 'line',
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
function activateChart(chartId) {
    const chartContext = document.getElementById(chartId);

    chart = new Chart(chartContext, config);


}

export {
    activateChart
}

