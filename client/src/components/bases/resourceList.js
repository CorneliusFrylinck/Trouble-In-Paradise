import { observer } from "mobx-react-lite";
import React from "react";
import ResourceComponent from "./resourceComponent";
import "./base.css";

const ResourceList = ({
    resources
}) => {

    return (
        <>
            <h3 className="text-left">Resources:</h3>
            <div className="resource-list">
                <ResourceComponent color="#5a3034" name={"Metal"} available={resources.metal} production={1000} />
                <ResourceComponent color="#e8c7e8" name={"Cement"} available={resources.cement} production={1000} />
                <ResourceComponent color="#724141" name={"Lumber"} available={resources.lumber} production={1000} />
                <ResourceComponent color="#61699a" name={"Water"} available={resources.water} production={1000} />
                <ResourceComponent color="#187661" name={"Food"} available={resources.food} production={1000} />
                <ResourceComponent color="#aeb8d1" name={"Oxygen"} available={resources.oxygen} production={1000} />
                <ResourceComponent color="#00c1ff" name={"Crystal_Blue"} available={resources.crystal_Blue} production={1000} />
                <ResourceComponent color="#ff0000" name={"Crystal_Red"} available={resources.crystal_Red} production={1000} />
                <ResourceComponent color="#a3a034" name={"Gold"} available={resources.gold} production={1000} />
            </div>
        </>
    )
}

export default observer(ResourceList);