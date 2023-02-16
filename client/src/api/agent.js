import axios from "axios";

axios.defaults.baseURL = "https://localhost:7275/api/";

const BaseRequests = {
    getBaseById: (id) => axios.get("bases/"+id).then(response => response.data)
}

const agent = {
    BaseRequests
}

export default agent;