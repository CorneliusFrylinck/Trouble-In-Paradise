import agent from "../api/agent.js";
import { makeAutoObservable } from "mobx";

export default class BuildingsStore {

    constructor() {
        makeAutoObservable(this);
    }

    getResourceBuildings = async(baseId, name) => {
        try {
            return await agent.BuildingRequests.getResourceBuildings(baseId, name);
        } catch(e) {
            console.log(e);
        }
    }
}