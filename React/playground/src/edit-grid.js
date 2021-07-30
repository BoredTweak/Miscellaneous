import ReactDataGrid, { TextEditor } from 'react-data-grid';
import { useState } from 'react';

const columns = [
  { key: 'id', name: 'ID', editable: true, editor: TextEditor },
  { key: 'title', name: 'Title', editable: true, editor: TextEditor }
];

let rowsInitial = [
  { id: 0, title: '' },
  { id: 2, title: '1' },
  { id: 4, title: 'asd' }
];


export default function EditGrid() {
    const [rows, setRows] = useState(rowsInitial);
  
    return (
        <ReactDataGrid columns={columns}
            rows={rows}
            onRowsChange={setRows} />
    );
}
