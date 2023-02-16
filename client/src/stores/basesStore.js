import { makeAutoObservable } from "mobx";
import agent from "../api/agent.js";

export default class BasesStore {
    base = undefined;

    constructor() {
        makeAutoObservable(this);
    }

    retrieveBase = async () => {
        return await agent.BaseRequests.getBaseById(1);
    }

    getBase = () => {
        return this.base;
    }
}