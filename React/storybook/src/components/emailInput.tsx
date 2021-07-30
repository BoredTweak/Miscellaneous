import React from "react";

export default function EmailInput(props: React.HTMLProps<HTMLInputElement>) : JSX.Element {
    return <input type="email" autoComplete="email" {...props}/>
}