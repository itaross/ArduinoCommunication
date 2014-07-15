using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArduinoCommunication {
    
    class Pin {
        
        private uint number;
        private String name;
        private pinMode mode;

        public enum pinMode {
            INPUT_PIN = 0,
            OUTPUT_PIN = 1
        };

        public Pin(uint number, String name, pinMode mode) {
            this.number = number;
            this.name = name;
            this.mode = mode;
        }
        
        public uint getNumber(){
            return this.number;
        }

        public String getName() {
            return this.name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public pinMode getMode() {
            return this.mode;
        }

        public void setMode(pinMode mode) {
            this.mode = mode;
        }

        public String toString() {
            return "Pin #" + this.number + "," + (this.mode == pinMode.INPUT_PIN ? "input" : "output") + ", " + this.name;
        }

    }
}
