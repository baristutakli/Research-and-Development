import {useState,useEffect} from 'react'
import List from './List'
import Form from './Form'

function Contacts() {
    const [contacts,setContacts]=useState([]);
    //useEffect ile bir atama yapıldığında son güncel hali kullanalim
    useEffect(()=>{
        console.log(contacts);
    },[contacts])
  return (<div>
    <List contacts={contacts}/>
    <Form addContact={setContacts} contacts={contacts}/>
</div>)
  
}
export default Contacts;