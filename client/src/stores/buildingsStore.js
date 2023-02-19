import agent from "../api/agent.js";
import { makeAutoObservable } from "mobx";

export default class BuildingsStore {

    constructor() {
        makeAutoObservable(this);
    }

    getResourceBuildings = async(baseId, name) => {
        try {
            return await agent.BuildingRequests.getResourceBuildingsByBuildingId(baseId, name);
        } catch(e) {
            console.log(e);
        }
    }
}