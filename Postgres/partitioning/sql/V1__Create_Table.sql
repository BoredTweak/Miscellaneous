CREATE TABLE toxicity_annotations (
    rev_id decimal,
    worker_id decimal,
    toxicity decimal,
    toxicity_score decimal 
) PARTITION BY RANGE(rev_id);

CREATE TABLE toxicity_annotations_rev0 PARTITION OF toxicity_annotations
    FOR VALUES FROM (0) TO (100000000.0);

CREATE TABLE toxicity_annotations_rev1 PARTITION OF toxicity_annotations
    FOR VALUES FROM (100000000.0) TO (200000000.0);

CREATE TABLE toxicity_annotations_rev2 PARTITION OF toxicity_annotations
    FOR VALUES FROM (200000000.0) TO (300000000.0);

CREATE TABLE toxicity_annotations_rev3 PARTITION OF toxicity_annotations
    FOR VALUES FROM (300000000.0) TO (400000000.0);

CREATE TABLE toxicity_annotations_rev4 PARTITION OF toxicity_annotations
    FOR VALUES FROM (400000000.0) TO (500000000.0);

CREATE TABLE toxicity_annotations_rev5 PARTITION OF toxicity_annotations
    FOR VALUES FROM (500000000.0) TO (600000000.0);

CREATE TABLE toxicity_annotations_rev6 PARTITION OF toxicity_annotations
    FOR VALUES FROM (600000000.0) TO (700000000.0);

CREATE INDEX ON toxicity_annotations (rev_id);
