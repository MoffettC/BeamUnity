using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AbstractBeamService : AbstractService{

    protected readonly BeamAPI beam;

    public AbstractBeamService(BeamAPI beam) {
           this.beam = beam;
        }

}

