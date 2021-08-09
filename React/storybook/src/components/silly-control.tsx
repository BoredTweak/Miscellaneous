import React from "react";

export interface Props {
    visible: boolean;
    list: string[];
}

export default function SillyControl(props: Props) : JSX.Element {
    return <div>{ props.visible ? 
    <div>
        <h4>If it's visible then you get the list!</h4>
        {props?.list?.map(item => <div><h6>{item}</h6></div>)}
    </div> : 
    <div></div> }</div>
}