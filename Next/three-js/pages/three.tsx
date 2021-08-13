import React, { useEffect, useState } from "react";
import * as THREE from "three";

export default function Three(): JSX.Element {
    const xMax = 8;
    const yMax = 8;
    const zMax = 8;

    const [initialized, setInitialized] = useState(false);

    // Create a single ThreeJS Box
    function generateBox(x: number, y: number, z: number, color: number) {
        var mesh = new THREE.Mesh(new THREE.BoxGeometry(1, 1, 1),
            new THREE.MeshBasicMaterial({ color: color }));
        mesh.position.x = x;
        mesh.position.y = y;
        mesh.position.z = z;
        return mesh;
    }

    useEffect(() => {
        if (initialized) {
            return;
        }

        // Create ThreeJS Scene
        var scene = new THREE.Scene();
        scene.add(new THREE.AmbientLight(0xffffff, 0.3));

        // Create ThreeJS Camera
        var camera = new THREE.PerspectiveCamera(60, window.innerWidth / window.innerHeight, 0.1, 100);
        camera.position.set(xMax * 2, yMax * 2, zMax * 2);
        camera.lookAt(0, 0, 0);

        // Mount renderer to three-canvas
        const rendererTarget = document.getElementById('three-canvas');
        var renderer = new THREE.WebGLRenderer({ canvas: rendererTarget });
        renderer.setSize(window.innerWidth, window.innerHeight);

        // Generate a 3 dimensional box of boxes
        for (let x = 0; x < xMax; x++) {
            for (let y = 0; y < yMax; y++) {
                for (let z = 0; z < zMax; z++) {
                    scene.add(generateBox(x, y, z, Math.random() * 0xffffff));
                }
            }
        }

        // If the Window is resized try to make the canvas pretty.
        var onWindowResize = function () {
            camera.aspect = window.innerWidth / window.innerHeight;
            camera.updateProjectionMatrix();
            renderer.setSize(window.innerWidth, window.innerHeight);
        }

        window.addEventListener('resize', onWindowResize, false);

        // Setup pretty picture
        var animate = function () {
            requestAnimationFrame(animate);
            renderer.render(scene, camera);
        };
        animate();

        setInitialized(true);
    }, [initialized, setInitialized]);

    return (
        <div>
            <canvas id="three-canvas" />
        </div>
    );
}
