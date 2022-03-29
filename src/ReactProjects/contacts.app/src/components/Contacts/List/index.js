import {useState} from 'react'

function List({contacts}) {
    const [filterText,setFilterText]=useState("");
    const filtered =contacts.filter((item)=>{
        return Object.keys(item).some((key)=>
            item[key]
            .toString()
            .toLowerCase()
            .includes(filterText.toLocaleLowerCase())
        );
    });
    console.log("filtered",filtered);
  return (
    <div>Contact List
        <input placeholder='Filter' 
        value={filterText} onChange={(e)=>setFilterText(e.target.value)}/>
        <ul>
           { contacts.map((contact,i)=>(<li key={i}> {contact.fullName}</li>))}
        </ul>
    </div>
  )
}

export default List;