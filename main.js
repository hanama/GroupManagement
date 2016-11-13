// Your code here!
/**
 * Created by MIchal on 01/09/2016.
 */

/*
Nqualification= Needed qualification
 */

var QUALIFICATION_TYPES = { //type definition. object with key values
    PROGRAMMER: "programmer",
    SECRITARY: "secritary"
};


var AVAILABILITY_TYPES = { //type definition. object with key values
    FREE: "free",
    BUSY: "busy"
};

//var a=[1,2,3,4,5,6,7,8,9] - levels of availebilety
var w = []; //all workers array
var worker = function () {
    return {
        id: undefined,
        qualification: undefined, //an attribute of worker
        availablity: undefined
    }
};

var m = []; //all missions array
var mission = function () {
    return {
        mid: undefined,
        priority: undefined,
        duration: undefined,
        endTime: undefined,
        mqualification: undefined //an attribute of worker
    }
};


/*testing*/
NewWorker();
NewWorker();
console.log(w); //print -output


function NewWorker(inqualification, inavailablity) {
    var tmpWorker = new worker(); // create a new worker with an input qualification and availablity.
    //tmpWorker.qualification = QUALIFICATION_TYPES.inqualification
    w.push(tmpWorker);// add the new worker to the workers array
}


function alg1() {
    var free_time = -1;
    var Nqualification;
    var chosen_worker = undefined;
    for (i = 0; i < w.length ; i++) {
        if (w[i].qualification == Nqualification) {
            if (w[i].availablity > free_time) {
                free_time = w[i].availablity;
                chosen_worker = w[i].id;
            }
        }
    }
    return chosen_worker
}


function alg2() {
    var mission_priority = -1
    var chosen_mission = undefined
    for (j = 0; j < m.length ; j++) {
        m[j].priority = x * m[j].duration + y * m[j].endTime
        if (m[j].priority > mission_priority) {
            var mission_priority = m[j].priority
            chosen_mission = m[j].id

        }

    }
    return chosen_mission
}