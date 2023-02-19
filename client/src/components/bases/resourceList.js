import { observer } from "mobx-react-lite";
import React, { useEffect, useState } from "react";
import ResourceComponent from "./resourceComponent";
import "./base.css";
import {useStore} from "./../../stores/store.js"

const ResourceList = ({
    baseId
}) => {

    const [resources, setResources] = useState(undefined);
    const [resourceProductions, setResourceProductions] = useState(undefined);

    const { basesStore } = useStore();

    useEffect(() => {
        try {
            GetResourceProductions();
            // On startup, create a timer to get the updated resources every second.
            GetResources();
        } catch(e) {}
    // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [])

    const GetResources = () => {
        setTimeout(() => {
            basesStore.retrieveResources().then(r => {
                setResources(r);
                GetResources();
            })
        }, 500)
    }

    const GetResourceProductions = () => {
        basesStore.retrieveResourceProductions().then(rp => {
            setResourceProductions(rp);
        })
    }

    if (resources === undefined) {
        return (<div>Resources loading...</div>)
    }

    return (
        <>
            <h3 className="text-left">Resources:</h3>
            <div className="resource-list">
                <ResourceComponent color="#5a4044" name={"Metal"} available={resources.metal} production={resourceProductions.metal} baseId={resources.baseId} />
                <ResourceComponent color="#e8c7e8" name={"Cement"} available={resources.cement} production={resourceProductions.cement} baseId={resources.baseId} />
                <ResourceComponent color="#833415" name={"Lumber"} available={resources.lumber} production={resourceProductions.lumber} baseId={resources.baseId} />
                <ResourceComponent color="#61699a" name={"Water"} available={resources.water} production={resourceProductions.water} baseId={resources.baseId} />
                <ResourceComponent color="#187661" name={"Food"} available={resources.food} production={resourceProductions.food} baseId={resources.baseId} />
                <ResourceComponent color="#aeb8e4" name={"Oxygen"} available={resources.oxygen} production={resourceProductions.oxygen} baseId={resources.baseId} />
                <ResourceComponent color="#00c1ff" name={"Blue_Crystal"} available={resources.blue_Crystal} production={resourceProductions.blue_Crystal} baseId={resources.baseId} />
                <ResourceComponent color="#ff0000" name={"Red_Crystal"} available={resources.red_Crystal} production={resourceProductions.red_Crystal} baseId={resources.baseId} />
                <ResourceComponent color="#a3a034" name={"Gold"} available={resources.gold} production={resourceProductions.gold} baseId={resources.baseId} />
            </div>
        </>
    )
}

export default observer(ResourceList);