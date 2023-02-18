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
                <ResourceComponent color="#5a4044" name={"Metal"} available={resources.metal} production={resourceProductions.metal} />
                <ResourceComponent color="#e8c7e8" name={"Cement"} available={resources.cement} production={resourceProductions.cement} />
                <ResourceComponent color="#833415" name={"Lumber"} available={resources.lumber} production={resourceProductions.lumber} />
                <ResourceComponent color="#61699a" name={"Water"} available={resources.water} production={resourceProductions.water} />
                <ResourceComponent color="#187661" name={"Food"} available={resources.food} production={resourceProductions.food} />
                <ResourceComponent color="#aeb8e4" name={"Oxygen"} available={resources.oxygen} production={resourceProductions.oxygen} />
                <ResourceComponent color="#00c1ff" name={"Blue_Crystal"} available={resources.blue_Crystal} production={resourceProductions.blue_Crystal} />
                <ResourceComponent color="#ff0000" name={"Red_Crystal"} available={resources.red_Crystal} production={resourceProductions.red_Crystal} />
                <ResourceComponent color="#a3a034" name={"Gold"} available={resources.gold} production={resourceProductions.gold} />
            </div>
        </>
    )
}

export default observer(ResourceList);