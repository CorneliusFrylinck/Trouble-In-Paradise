import { observer } from "mobx-react-lite";
import React, { useEffect, useState } from "react";
import ResourceComponent from "./resourceComponent";
import "./base.css";
import {useStore} from "./../../stores/store.js"

const ResourceList = ({
    resources
}) => {

    const [res, setRes] = useState(undefined);

    const { basesStore } = useStore();

    useEffect(() => {
        // On startup, create a timer to get the updated resources every second.
        setInterval(() => {
            GetResources();
        }, 3000);
    }, [])

    const GetResources = () => {
        basesStore.retrieveResources().then(r => {
            setRes(r);
        })
    }

    if (res === undefined) {
        return (<div>Resources loading...</div>)
    }

    return (
        <>
            <h3 className="text-left">Resources:</h3>
            <div className="resource-list">
                <ResourceComponent color="#5a4044" name={"Metal"} available={res.metal} production={100} />
                <ResourceComponent color="#e8c7e8" name={"Cement"} available={res.cement} production={100} />
                <ResourceComponent color="#833415" name={"Lumber"} available={res.lumber} production={100} />
                <ResourceComponent color="#61699a" name={"Water"} available={res.water} production={100} />
                <ResourceComponent color="#187661" name={"Food"} available={res.food} production={100} />
                <ResourceComponent color="#aeb8e4" name={"Oxygen"} available={res.oxygen} production={100} />
                <ResourceComponent color="#00c1ff" name={"Crystal_Blue"} available={res.crystal_Blue} production={100} />
                <ResourceComponent color="#ff0000" name={"Crystal_Red"} available={res.crystal_Red} production={100} />
                <ResourceComponent color="#a3a034" name={"Gold"} available={res.gold} production={5} />
            </div>
        </>
    )
}

export default observer(ResourceList);