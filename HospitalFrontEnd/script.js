$(document).ready(function(){
     $("#addPatientForm").validate({
         rules:{
             fname:{
                 required: true,
                 minlength:3
             },
             lname:{required: true} ,
             gender:{required:true} ,
             symtoms:{required: true}
    
         },
         messages:{
             fname:{
                 required: 'First name is required',
                 minlength:'Min lenght required is 3 char'
             },
             lname: 'Last name is required',
             gender: ' Gender is required',
             symtoms: ' Please describe the symtoms'
         },

         submitHandler:function(form){

            console.log(`${form.fname.value} ${form.lname.value} ${form.gender.value} ${form.symtoms.value}`);

            var payload = {
                "Name": form.fname.value,
                "Last_name": form.lname.value,
                "Gender":form.gender.value,
                "Symptoms":form.symtoms.value
            };
            console.log("person (payload) - ", payload);

            $.ajax({  
                url: 'https://localhost:44391/api/Patient/add-patient',  
                headers: { 
                    'Accept': 'application/json',
                    'Content-Type': 'application/json' 
                },
                type: 'POST',  
                dataType: 'json',  
                data: JSON.stringify(payload),  
                success: function (data, textStatus, xhr) {  
                    console.log(data);  
                    alert("Succed");
                },  
                
                error:function(xhr, textStatus,errorThrown){
                    console.log('Error in Operation');
                }  
            });  

        }
    }) 


   
    $("#addDoctorForm").validate({
        rules:{
            fname:{
                required: true,
                minlength:3
            },
            lname:{required: true} ,
            doctorPhone:{required:true} ,
            email:{required: true , email:true}
   
        },
        messages:{
            fname:{
                required: 'First name is required',
                minlength:'Min lenght required is 3 char'
            },
            lname: 'Last name is required',
            doctorPhone: ' Phone number is required',
            email:{required: ' Email required', 
                      email:"Email required"}
        },

       submitHandler:function(form){

           console.log(`${form.fname.value} ${form.lname.value} ${form.doctorPhone.value} ${form.email.value}`);

           var payload = {
               "Name": form.fname.value,
               "Surname": form.lname.value,
               "PhoneNumber":form.doctorPhone.value,
               "Email":form.email.value
           };
           

           $.ajax({  
               url: 'https://localhost:44391/api/Doctor/add-doctor',  
               headers: { 
                   'Accept': 'application/json',
                   'Content-Type': 'application/json' 
               },
               type: 'POST',  
               dataType: 'json',  
               data: JSON.stringify(payload),  
               success: function (data, textStatus, xhr) {  
                   console.log(data);  
                   alert("Succed");
               },  
               
               error:function(xhr, textStatus,errorThrown){
                   console.log('Error in Operation');
               }  

            });
        
        }

    })

  }); 
      
 function getDoctors(){
    $.ajax({  
        url: "https://localhost:44391/api/Doctor/get-all-doctors",  
        headers: { 
            'Accept': 'application/json',
            'Content-Type': 'application/json' 
        },
        type: "GET",  
        dataType: "json",  
        success: function (data) {  
            console.log(data);

            var _response = '';
            $.each(data, function(i, item) {
                _response += '<tr><th scope="row">'+item.Id+'</th><td>' + item.Name + '</td><td>' + item.Surname + '</td></tr>'+'</td><td>' + item.PhoneNumber + '</td></tr>'+'</td><td>' + item.Email + '</td></tr>'+ '</td><td>' + item.RegistrationTime + '</td></tr>';
            });
            $('table tbody').html(_response);
            
        }, 

        failure: function (data) {  
            alert(data.responseText);  
            console.log(data);
        }, //End of AJAX failure function  
        error: function (data) {  
            alert(data.responseText);  
            console.log(data);

        } //End of AJAX error function  

    });
}





