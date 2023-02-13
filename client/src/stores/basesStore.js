import { makeAutoObservable } from "mobx";
import agent from "../api/agent.js";

export default class BasesStore {
    base = undefined;

    constructor() {
        makeAutoObservable(this);
    }

    retrieveBase = async () => {
        return await agent.BaseRequests.get("bases");
    }

    getBase = () => {
        return this.base;
    }
}