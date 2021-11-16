//Libs
import React, { useState } from 'react';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import { FaUserShield, FaUserPlus, FaUserMd } from 'react-icons/fa';

//Services
import { parseJWT } from '../services/Auth';

//Styles
import '../styles/pages/Navigation.css';

//Components
import Header from '../components/Header';
import Sidebar from '../components/Sidebar';

//Pages
import Dashboard from '../pages/Dashboard';
import Home from '../pages/Home';
import Users from '../pages/Users';
import Appointments from '../pages/Appointments';

//SidebarData
import SidebarData from '../components/SidebarData';
import PatientSidebarData from '../components/PatientSidebarData';

const Navigation = () => {
  //User role authorization
  const role = parseJWT().role;
  const nomePaciente = parseJWT().nomePaciente;
  const nomeMedico = parseJWT().nomeMedico;

  //Sidebar
  const [showSidebar, setShowSidebar] = useState(true);

  return (
    <div className="navigation__container">
      <Router>
        <div className="navigation__content">
          <Header
            username={
              (role === '1' && 'Admin') ||
              (role === '2' && nomePaciente) ||
              (role === '3' && nomeMedico)
            }
            icon={
              (role === '1' && <FaUserShield />) ||
              (role === '2' && <FaUserPlus />) ||
              (role === '3' && <FaUserMd />)
            }
            showSidebar={showSidebar}
            setShowSidebar={setShowSidebar}
          />

          <main className="navigation__main">
            {role === '1' ? (
              <>
                <Route path="/dashboard" component={Dashboard} />
                <Route path="/usuarios" component={Users} />
              </>
            ) : (
              <Route path="/inicio" component={Home} />
              )}

            <Route path="/consultas" component={Appointments} />
          </main>
        </div>
      <Sidebar
        showSidebar={showSidebar}
        sidebarData={role === '1' ? SidebarData : PatientSidebarData}
      />
      </Router>
    </div>
  );
};

export default Navigation;
