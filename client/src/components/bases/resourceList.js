import { observer } from "mobx-react-lite";
import React from "react";
import ResourceComponent from "./resourceComponent";

const ResourceList = ({
    resources
}) => {

    return (
        <>
            <ResourceComponent name={"Metal"} available={resources.metal} production={1000} />
            <ResourceComponent name={"Cement"} available={resources.cement} production={1000} />
            <ResourceComponent name={"Lumber"} available={resources.lumber} production={1000} />
            <ResourceComponent name={"Water"} available={resources.water} production={1000} />
            <ResourceComponent name={"Food"} available={resources.food} production={1000} />
            <ResourceComponent name={"Oxygen"} available={resources.oxygen} production={1000} />
            <ResourceComponent name={"Crystal_Blue"} available={resources.crystal_Blue} production={1000} />
            <ResourceComponent name={"Crystal_Red"} available={resources.crystal_Red} production={1000} />
            <ResourceComponent name={"Gold"} available={resources.gold} production={1000} />
        </>
    )
}

export default observer(ResourceList);