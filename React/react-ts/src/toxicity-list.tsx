import { useEffect, useState } from "react";

import config from "./config.json";

export interface ApiResponse {
    result: ApiResult;
}

export interface ApiResult {
    toxicity_annotations : ToxicityAnnotation[];
}

export interface ToxicityAnnotation {
    rev_id: number;
    worker_id: number;
    toxicity: number;
    toxicity_score: number;
}

export default function ToxicityList() {
    const [initialCallFinished, setInitialCallFinished] = useState<boolean>(false);
    const [state, setState] = useState<ToxicityAnnotation | undefined>(undefined);

    useEffect(() => {
        if(!initialCallFinished) {
            fetch(config.api_host + "/annotations")
                .then(response => response.json())
                .then(result => setState((result as ApiResponse).result.toxicity_annotations[0]));
            setInitialCallFinished(true);
        }
    }, [initialCallFinished, setInitialCallFinished, setState]);

    return <h1>{state?.rev_id}</h1>;
}
