using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    public class ObstacleFacade
    {
        private Pole pole;
        private Tree tree;
        private Cloud cloud;
        private Stone stone;
        private Red red;
        private Green green;
        private Yellow yellow;
        private Grey grey;
        private Blue blue;

        public ObstacleFacade()
        {
            pole = new Pole();
            tree = new Tree();
            cloud = new Cloud();
            stone = new Stone();
            red = new Red();
            green = new Green();
            grey = new Grey();
            blue = new Blue();
            yellow = new Yellow();
        }

        public void drawGreyPole()
        {
            grey.fill();
            pole.draw();         
        }

        public void drawGreenTree()
        {
            green.fill();
            tree.draw();       
        }

        public void drawBlueCloud()
        {
            blue.fill();
            cloud.draw();          
        }

        public void drawYellowStone()
        {
            yellow.fill();
            stone.draw();       
        }

        public void drawRedStone()
        {
            red.fill();
            stone.draw();          
        }

        public void calculateDIstanceBetweenObstacles() { }

        public void checkPrevObstacle() { }
    }
}
