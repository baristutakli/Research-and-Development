import {useState,useEffect} from 'react'
const initialFormValues={fullName:"",phone_number:""}
function Form({addContact,contacts}) {
    const [form,setForm] = useState(initialFormValues);
    const onChangeInput =(e)=>{
        setForm({...form,[e.target.name]:[e.target.value]});
    }
    useEffect(()=>{
        setForm(initialFormValues);
    },[contacts])
    const onSubmit =(e)=>{
        e.preventDefault();
        if(form.fullName===''|| form.phone_number==='')
        {
            // koşulları sağlamaz ise form submit olmaz
            return false;
        }
        addContact([...contacts,form]);
        // iki farklı yöntemle yapabiliriz
        //setForm(initialFormValues);
        // useEffect kullanarak ta capabiliriz
        // contacts değiştikten sonra input içini boşaltabiliriz

       
    }
  return (
    <form onSubmit={onSubmit} >
        <div>
        <input name='fullName' placeholder='Fullname' onChange={onChangeInput} value={form.fullName}/>
        </div>
        <div>
        <input name='phone_number'placeholder='Phone Number'onChange={onChangeInput} value={form.phone_number}/>
        </div>
        
        <div className='btn'>
            <button >Add</button>
        </div>
    </form>
  )
}

export default Form;