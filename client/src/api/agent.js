import axios from "axios";

axios.defaults.baseURL = "https://localhost:7275/api/";

const BaseRequests = {
    get: (url) => axios.get(url).then(response => response.data)
}

const agent = {
    BaseRequests
}

export default agent;