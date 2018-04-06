using System;
using System.Collections.Generic;

namespace FitnessAppAPI1
{


	 public class ProgramFac:AutoFac<Program>
	 {

        public FullProgram GetFullProgram(int id)
        {
            SessionFac sf = new SessionFac();
            FullProgram fp = new FullProgram();
            SessionItemFac sif = new SessionItemFac();

            fp.program = Get(id);

            List<Sessiondetails> sdl = new List<Sessiondetails>();
            
            foreach (var item in sf.GetBy("ProgramID", id, "Sorting"))
            {
                Sessiondetails sd = new Sessiondetails();

                sd.session = item;

                sd.sessionItems = sif.GetSessionItems(item.ID);

                sdl.Add(sd);
            }

            fp.sessionDetails = sdl;

            return fp;
        }

	 }

}
