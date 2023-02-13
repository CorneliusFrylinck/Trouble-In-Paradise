import { makeAutoObservable } from "mobx";
import agent from "../api/agent.js";

export default class BasesStore {
    base = null;

    constructor() {
        makeAutoObservable(this);
    }

    getBase = async () => {
        return await agent.BaseRequests.get("bases");
    }
}