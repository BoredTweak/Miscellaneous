import Head from "next/head";
import Link from "next/link";
import React from "react";

export default function Header(): JSX.Element {
    return <div id="header" className="header">
        <Head>
            <nav id="header-nav" className="header-nav">
                <div>
                    <Link href="/">
                        <a><h1>Non-Zero Days</h1></a>
                    </Link>
                </div>
                <div>
                    <Link href="/three">
                        <a>ThreeJS Sample</a>
                    </Link>
                </div>
            </nav>
        </Head>

    </div>
}