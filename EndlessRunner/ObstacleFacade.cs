using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessRunner
{
    public class ObstacleFacade
    {
        private Shape pole;
        private Shape tree;
        private Shape cloud;
        private Shape stone;
        private Color red;
        private Color green;
        private Color yellow;
        private Color grey;
        private Color blue;

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
