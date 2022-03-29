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
        <ul className='list'>
           { contacts.map((contact,i)=>(<li key={i}>
              <span>{contact.fullName}</span>
              <span>{contact.phone_number}</span>
              </li>))}
        </ul>
        <p>Total Contacts:{filtered.length}</p>
    </div>
  )
}

export default List;