$(function ()
{ $("#example").popover();
html: true
});


$(function ()
{ $('#example').typeahead()  ;
});


 
  
  $(document).ready(function () {
                $("button").tooltip({
                  'selector': '',
                  'placement': 'bottom'
                });
              });
           

$(window).load(function(){
$('.btn-blue').click(function(){
    $(this).toggleClass('loading');
});
});





 var subjects = ['Car Rentals', 'Hotels', 'Cruises', 'Vacations', 'Cheap Vacations', 'Cheap Car Rentals', 'Flights', ];   
$('#search').typeahead({source: subjects})  
 


 var subjects = ['Canada', 'United States', 'Cambodia', 'Caribe', 'France', 'Italy', 'United Kingdom',];   
$('#search2').typeahead({source: subjects})  
 




$().ready(function(){

  $('input.prettyCheckable').prettyCheckable({
    labelPosition: 'right'
  });

  $('input[name=colors]').on('change', function(){

    if ($(this).val() === 'yes') {

      $('div#other-colors').slideDown();

    } else {

      $('div#other-colors').slideUp();

    }

  });



});
