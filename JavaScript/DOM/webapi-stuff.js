function injectElements()
{
    var element = document.createElement("div");
    fetch('http://localhost:8080/annotations')
      .then(response => response.json())
      .then(data => data.result.toxicity_annotations.map(item => {
        element.appendChild(document.createTextNode(item.rev_id));
        document.getElementById('target-for-injection').appendChild(element);
      }));
}
