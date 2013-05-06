% this routine calculates the number of cross-overs 
function x=CalculateCrossOvers(patch) 
    x1 = (patch(2,3)~=patch(1,2)) + (patch(1,2)~=patch(2,1)) + ... 
    (patch(2,1)~=patch(3,2)) + (patch(3,2)~=patch(2,3)); 

    x2 = (~patch(2,3) && patch(1,3) && ~patch(1,2)) + ... 
    (~patch(2,1) && patch(1,1) && ~patch(1,2)) + ... 
    (~patch(2,1) && patch(3,1) && ~patch(3,2)) + ... 
    (~patch(3,2) && patch(3,3) && ~patch(2,3)); 

    x = x1 + 2*x2; 
end 